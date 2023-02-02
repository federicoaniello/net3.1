var swiper = new Swiper(".product--list", {
    slidesPerView: 2,
    spaceBetween: 10,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    breakpoints: {
        768: {
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
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    breakpoints: {
        768: {
            slidesPerView: 8,
            spaceBetween: 20
        }
    }
});