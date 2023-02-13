
const utilityFunction = () => {

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
            }).catch(error => { reject(error) })
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

export default utilityFunction;