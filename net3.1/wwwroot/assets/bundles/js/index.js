import utilityFunction from "./utilities.js";

const { download, populate } = utilityFunction();
const brands_component = document.getElementById("brands-component");
const brands_swiper_container = document.getElementById("swiper-brands-container");
const header_searchbar = document.getElementById('header-searchbar');
const mobile_hamburger_button = document.getElementById('hamburger-mobile-button');
const header_tabs = document.getElementById('header-tabs');
const archi_navbar = document.getElementById('archi-navbar');
mobile_hamburger_button.onclick = () => {
    document.body.classList.toggle('mobile-menu');

}
header_searchbar.addEventListener('input', function (e) {
    console.log(e.target.value);
    if (e.target.value !== "") {
        e.target.parentElement.classList.add('typing');
    }
    else {
        e.target.parentElement.classList.remove('typing');
    }
})

new ResizeObserver((entries) => {
    entries.forEach(entry => {
        const { width } = entry.contentRect;
        if (width > 767) {
            document.body.classList.remove("mobile-menu");
        }
    })
}).observe(document.body);





/**
* Callback da eseguire ogni volta nell'intersection observer
*/
const brandsCallback = (entries, observer) => {

    entries.forEach((entry) => {
        console.log('ENTRY = ',entry)
        if (entry.isIntersecting) {
            console.log("INTERSECTED");
            download("/Brands/GetAllBrands").then(val => {
                populate(val, brands_swiper_container, "brand", "/images/brands/");
                initializeSwiper();
                observer.unobserve(entry.target);
            }).catch(err => { throw err });
        }
    })
}



    /**
     * Inizializza Swiper.
     */
function initializeSwiper() {
    const arrowPrev = document.createElement('div');
    arrowPrev.classList.add('swiper-button-prev');
    const arrowNext = document.createElement('div');
    arrowNext.classList.add('swiper-button-next');
    const arrowsArray = [arrowPrev, arrowNext];
    brands_component.getElementsByTagName('div')[0].append(...arrowsArray);




        const swiperParams = {
        slidesPerView: 2,
    watchSlidesVisibility: true,
    preloadImages: false,
    spaceBetween: 30,
            navigation: true,
    breakpoints: {
        768: {
        slidesPerView: 4,
    spaceBetween: 20
        },
        992: {
            slidesPerView:8
            }
            },
            navigation: {
                nextEl: '.swiper-button-next',
                prevEl: '.swiper-button-prev',
            }
};

    Object.assign(brands_swiper_container, swiperParams);
    brands_swiper_container.initialize();
    brands_swiper_container.style.opacity = 1;

    }



    const brands_component_observer = new IntersectionObserver(brandsCallback,{root: null, threshold: 0.1});
    brands_component_observer.observe(brands_component);






header_tabs.querySelectorAll('.tab').forEach(tab => {
    if (window.innerWidth > 767) {
        tab.addEventListener('mouseenter', function (e) {
            tab.classList.add('show-tabs')
        }),
            tab.addEventListener('mouseleave', function (e) {
                tab.classList.remove('show-tabs')
            })
    }


})










