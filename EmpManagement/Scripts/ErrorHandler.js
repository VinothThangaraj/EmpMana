function errorHandler(jqXhr) {

    // alert(jqXhr.status);
    //$("#internetDisconnectAlert").removeAttr("aria-hidden=true");
    if (jqXhr.readyState == 4) {
        switch (jqXhr.status) {
            case 0:
                //   alert(jqXhr.status);
                $(".overlay-for-internet-down").show();
                $("#internetDisconnectAlert").show();
                //toastr.error("Please check your internet connection.");
                //alert("Please check your internet connection.");
                break;
            case 401:
                toastr.error("Unauthorized access.");
                //alert("Unauthorized access");
                break;
            case 404:
                toastr.error("Page not found.");
                //alert("Page not found");
                break;
            case 500:
                toastr.error("Oops something went wrong, Try again later.");
                //toastr.error("Internal server error");
                //alert("Internal server error");
                break;
            default:
                toastr.error("Oops something went wrong, Try again later.");
                //alert("Oops something went wrong, Try again later.");
                break;
        }
    }
    else {
        console.log(jqXhr);
        console.log("error in else");
    }
}