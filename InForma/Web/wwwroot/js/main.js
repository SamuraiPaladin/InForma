// MENU SIDENAV
$(".button-collapse").sideNav();

// PARALLAX
$(document).ready(function () {
  $('.parallax').parallax();
});

//MODAL
$(document).ready(function () {
  // the "href" attribute of the modal trigger must specify the modal ID that wants to be triggered
  $('.modal').modal();
});

document.addEventListener('DOMContentLoaded', function() {
  var elems = document.querySelectorAll('.datepicker');
  var instances = M.Datepicker.init(elems, options);
});