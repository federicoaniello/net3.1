const { createApp } = Vue;
const brands_component = document.getElementById("brands-component");
const brands_swiper_container = document.getElementById("swiper-brands-container");
const header_searchbar = document.getElementById('header-searchbar');
const mobile_hamburger_button = document.getElementById('hamburger-mobile-button');
const header_tabs = document.getElementById('header-tabs');
const archi_navbar = document.getElementById('archi-navbar');
mobile_hamburger_button.onclick = () => {
    archi_navbar.classList.toggle('mobile-menu');

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




const  utilityFunction =() => {

    /**
* Scarica le immagini utilizzando il link selezionato
*/
    function download(link) {
        return new Promise((resolve, reject) => {
            fetch(link).then(res => {
                if (!res.ok) reject();
                res.json().then(value => {
                    resolve(value)
                })
            }).catch(error => {  reject(error) })
        })
    };



    /**
* Crea le swiper-slide per l elemento swiper in base ai risultati dell'API, e li inserisce nello swiper-container.
*/
    function populate(arrayOfValues, container, swiperSlideClass, path) {
        let divsContainer = [];
        const slide = document.createElement('swiper-slide');
        slide.style.height = 'auto';
        slide.setAttribute('lazy', "true");
        const slide_div = document.createElement('div');
        slide_div.classList.add(swiperSlideClass, 'h-100');
        const img = document.createElement('img');
        img.classList.add('w-100', 'p-2');
        img.loading = "lazy";
        slide_div.append(img);
        slide.append(slide_div);
        arrayOfValues.forEach(el => {
            const clonedNode = slide.cloneNode(true);
            clonedNode.querySelector('img').src = `${path}${el.img}`;
            divsContainer.push(clonedNode);
        })
        container.append(...divsContainer);
    }


    return {
        download,
        populate
    }
}




const { download, populate } = utilityFunction();

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
        slidesPerView: 8,
    spaceBetween: 20
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


//var swiper = new Swiper(".product--list", {
//    slidesPerView: 1.5,
//    centeredSlides:true,
//    spaceBetween: 10,
//    navigation: true,
//    breakpoints: {
//        768: {
//            centeredSlides: false,
//            slidesPerView: 4,
//            spaceBetween: 20
//        }
//    }
//});






createApp({
    data() {
        return {
            count: 0
        }
    },
    methods: {
        increment() {
            this.count++
        }
        }
}).mount('#partial-products');


















