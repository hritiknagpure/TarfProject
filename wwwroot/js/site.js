// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.onscroll = function () {
    document.getElementById('scrollTopBtn').style.display =
        window.scrollY > 200 ? 'block' : 'none';
};
document.getElementById('scrollTopBtn').onclick = function () {
    window.scrollTo({ top: 0, behavior: 'smooth' });
};
