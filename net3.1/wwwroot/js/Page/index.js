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
