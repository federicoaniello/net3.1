
<template>
    <main id="partial-products" class="position-relative">
        <section class="g-0 g-md-4 container-md position-relative" ref="swiperpartials">
            <h3 class="text-center py-5 py-md-0">Prodotti in vetrina</h3>
            <swiper-container ref="swiperm" class="products" init="false">
                <swiper-slide v-for="(prod,index) of products" class="product" lazy="true">
                    <img loading="lazy" :src="['/images/products/' + prod.img]">
                    <div class="info text-center my-2">
                        <h6>{{ prod.name }}</h6>
                        <h5 class="fw-bold">{{ prod.category }}</h5>
                        <h5>{{ prod.description }}</h5>
                        <p class="fw-bold">€ {{ formattedPrice(prod.price) }}</p>
                    </div>
                </swiper-slide>
            </swiper-container>
            <div class="product--item swiper-button-prev"></div>
            <div class="product--item swiper-button-next"></div>
        </section>
    </main>
</template>
<script>
import { ref,computed,onMounted } from "vue";
import utilityFunction from "../../wwwroot/js/Page/utilities";
    export default {
        name:"products-component",
        setup() {
            const { download } = utilityFunction();
            const swiperpartials = ref(null);
            const swiperm = ref(null);
            const products = ref([]);
            const formattedPrice = computed(() => param => {
                const formatter = new Intl.NumberFormat('it-IT', {
                    style: 'decimal',
                    currency: 'EUR',
                    minimumFractionDigits: 2
                });
                return formatter.format(param)
            })

            const swiperConf = {
                slidesPerView: 1.5,
                centeredSlides: true,
                spaceBetween: 10,
                navigation: true,
                breakpoints: {
                    768: {
                        centeredSlides: false,
                        slidesPerView: 4,
                        spaceBetween: 20
                    }
                },
                navigation: {
                    nextEl: '.swiper-button-next .product--item',
                    prevEl: '.swiper-button-prev .product--item',
                }
            }





            onMounted(() => {
                const callback = (entries, observer) => {
                    entries.forEach(({ target, isIntersecting }) => {
                        if (isIntersecting) {
                            download("/Products/GetAllProducts").then(prds => {
                                products.value = prds;
                                Object.assign(swiperm.value, swiperConf);
                                swiperm.value.initialize();
                                observer.unobserve(target);
                            });
                        }
                    });
                };
                const obs = new IntersectionObserver(callback, {
                    root: null,
                    threshold: 0.1,
                });
                obs.observe(swiperpartials.value);




            })

            return {
                products,
                swiperpartials,
                swiperm,
                formattedPrice

            }
        }

        }
</script>
<style scoped lang="scss">

</style>