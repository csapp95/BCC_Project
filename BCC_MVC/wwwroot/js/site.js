// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
   
    $('.movie-info-item').on('click', function (e) {
        e.preventDefault();
        var element = e.target;
        console.log(element);
    });
});