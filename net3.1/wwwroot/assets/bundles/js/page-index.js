var swiper = new Swiper(".product--list", {
    slidesPerView: 2,
    spaceBetween: 10,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    breakpoints: {
        // when window width is >= 320px
        768: {
            slidesPerView: 4,
            spaceBetween: 20
        }
    }
});
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

console.log('TEST');

function test() {
    var variable_x = 34;

    console.log(variable_x);
    return variable_x;


}
