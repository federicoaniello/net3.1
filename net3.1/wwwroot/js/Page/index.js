const brands_component = document.getElementById("brands-component");
const brands_swiper_container = document.getElementById("swiper-brands-container");
const { download, populate } = utilityFunction();

    



    /**
    * Callback da eseguire ogni volta nell'intersection observer
    */
    const brandsCallback = (entries, observer) => {
        entries.forEach((entry) => {
            console.log(entry)
            if (entry.isIntersecting) {
                console.log("INTERSECTED");
                download("/Brands/GetAllBrands").then(val => {
                    populate(val, brands_swiper_container, "brand", "/images/brands/");
                    initializeSwiper();
                    observer.unobserve(entry.target);
                });
            }
        })
    }





    /**
     * Inizializza Swiper.
     */
    function initializeSwiper(){

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


















function utilityFunction() {

    /**
* Scarica le immagini utilizzando il link selezionato
*/
    function download(link) {
        return new Promise((resolve, reject) => {
            fetch(link).then(res => {
                if (res.statusText !== "OK") reject();
                res.json().then(value => {
                    resolve(value)
                })
            })
        })
    };



    /**
* Crea le swiper-slide per l elemento swiper in base ai risultati dell'API, e li inserisce nello swiper-container.
*/
    function populate(arrayOfValues, container, swiperSlideClass, path) {
        const slide = document.createElement('swiper-slide');
        slide.setAttribute('lazy', "true");
        const slide_div = document.createElement('div');
        slide_div.classList.add(swiperSlideClass, 'h-100');
        const img = document.createElement('img');
        img.classList.add('w-100');
        img.loading = "lazy";
        slide_div.append(img);
        slide.append(slide_div);
        arrayOfValues.forEach(el => {
            const clonedNode = slide.cloneNode(true);
            clonedNode.querySelector('img').setAttribute('src', `${path}${el.img}`);
            container.append(clonedNode);
        })
    }


    return {
        download,
        populate
    }
}