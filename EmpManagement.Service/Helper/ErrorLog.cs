using log4net;
using System;
using System.Data.Entity.Validation;

namespace EmpManagement.Service.Helper
{
    public class ErrorLog
    {
        private static ILog logger = LogManager.GetLogger("ErrorLog");

        public static void HandleException(Exception exception)
        {

            if (exception is DbEntityValidationException)
            {
                DbEntityValidationException dbException = (DbEntityValidationException)exception;

                foreach (var entityErrors in dbException.EntityValidationErrors)
                {
                    logger.ErrorFormat("Entity of type \"{0}\" in state \"{1}\" has the following validation errors", entityErrors.Entry.Entity.GetType().Name, entityErrors.Entry.State);

                    foreach (var validationErrors in entityErrors.ValidationErrors)
                    {
                        logger.ErrorFormat("- Property: \"{0}\", Error: \"{1}\"", validationErrors.PropertyName, validationErrors.ErrorMessage);

                    }
                }
            }
            else
            {
                logger.ErrorFormat("Generic error of type \"{0}\" in state \"{1}\" has the following errors", exception.Message, exception.StackTrace);
            }
        }

        public static void HandleInfo(string obj)
        {
            logger.Info(obj);
        }
    }
}
