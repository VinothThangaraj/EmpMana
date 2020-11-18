/***
  File Name      : layout.js
  Description    : Jquery codes to for layouts
  Created Date   : 02-Mar-2017
  Notes          : <Notes>
***/

/* Top menu bar active class */
var selector = '.nav li';

$(selector).on('click', function () {
    $(selector).removeClass('active');
    $(this).addClass('active');
});

/* Flag Popup */
$('#flagOthers').hide();
$('#rejectOthers').hide();
$('#chkFlag').click(function () {
    var $this = $(this);
    if ($this.is(':checked')) {
        $('#flagOthers').show();
    } else {
        $('#flagOthers').hide();
    }
});

/* Reject Popup */
$('#chkReject').click(function () {
    var $this = $(this);
    if ($this.is(':checked')) {
        $('#rejectOthers').show();
    } else {
        $('#rejectOthers').hide();
    }
});