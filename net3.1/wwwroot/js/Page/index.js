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