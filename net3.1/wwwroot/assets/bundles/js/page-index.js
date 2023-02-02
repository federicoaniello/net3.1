var swiper = new Swiper(".product--list", {
    slidesPerView: 1.5,
    centeredSlides:true,
    spaceBetween: 10,
    navigation: true,
    breakpoints: {
        768: {
            centeredSlides: false,
            slidesPerView: 4,
            spaceBetween: 20
        }
    }
});

var swiper = new Swiper(".brands-list", {
    slidesPerView: 2,
    watchSlidesVisibility: true,
    preloadImages: false,
    lazy: true,
    spaceBetween: 30,
    navigation: true,
    breakpoints: {
        768: {
            slidesPerView: 8,
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
