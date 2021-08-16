// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




var test = document.getElementById('b1');
document.getElementById("b1").onclick = function () {test1() };

function test1() {
    alert("Test Success");
}
test.onload(test1());



