/*
 * ATTENTION: The "eval" devtool has been used (maybe by default in mode: "development").
 * This devtool is neither made for production nor for readable output files.
 * It uses "eval()" calls to create a separate source file in the browser devtools.
 * If you are trying to read the output file, select a different devtool (https://webpack.js.org/configuration/devtool/)
 * or disable the default devtool with "devtool: false".
 * If you are looking for production-ready output files, see mode: "production" (https://webpack.js.org/configuration/mode/).
 */
/******/ (() => { // webpackBootstrap
/******/ 	"use strict";
/******/ 	var __webpack_modules__ = ({

/***/ "./wwwroot/js/Page/index.js":
/*!**********************************!*\
  !*** ./wwwroot/js/Page/index.js ***!
  \**********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

eval("__webpack_require__.r(__webpack_exports__);\n/* harmony import */ var _utilities_js__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./utilities.js */ \"./wwwroot/js/Page/utilities.js\");\n\nconst {\n  createApp,\n  ref,\n  onMounted,\n  computed\n} = Vue;\nconst {\n  download,\n  populate\n} = (0,_utilities_js__WEBPACK_IMPORTED_MODULE_0__[\"default\"])();\nconst brands_component = document.getElementById(\"brands-component\");\nconst brands_swiper_container = document.getElementById(\"swiper-brands-container\");\nconst header_searchbar = document.getElementById('header-searchbar');\nconst mobile_hamburger_button = document.getElementById('hamburger-mobile-button');\nconst header_tabs = document.getElementById('header-tabs');\nconst archi_navbar = document.getElementById('archi-navbar');\nmobile_hamburger_button.onclick = () => {\n  document.body.classList.toggle('mobile-menu');\n};\nheader_searchbar.addEventListener('input', function (e) {\n  console.log(e.target.value);\n  if (e.target.value !== \"\") {\n    e.target.parentElement.classList.add('typing');\n  } else {\n    e.target.parentElement.classList.remove('typing');\n  }\n});\nnew ResizeObserver(entries => {\n  entries.forEach(entry => {\n    const {\n      width\n    } = entry.contentRect;\n    if (width > 767) {\n      document.body.classList.remove(\"mobile-menu\");\n    }\n  });\n}).observe(document.body);\n\n/**\r\n* Callback da eseguire ogni volta nell'intersection observer\r\n*/\nconst brandsCallback = (entries, observer) => {\n  entries.forEach(entry => {\n    console.log('ENTRY = ', entry);\n    if (entry.isIntersecting) {\n      console.log(\"INTERSECTED\");\n      download(\"/Brands/GetAllBrands\").then(val => {\n        populate(val, brands_swiper_container, \"brand\", \"/images/brands/\");\n        initializeSwiper();\n        observer.unobserve(entry.target);\n      }).catch(err => {\n        throw err;\n      });\n    }\n  });\n};\n\n/**\r\n * Inizializza Swiper.\r\n */\nfunction initializeSwiper() {\n  const arrowPrev = document.createElement('div');\n  arrowPrev.classList.add('swiper-button-prev');\n  const arrowNext = document.createElement('div');\n  arrowNext.classList.add('swiper-button-next');\n  const arrowsArray = [arrowPrev, arrowNext];\n  brands_component.getElementsByTagName('div')[0].append(...arrowsArray);\n  const swiperParams = {\n    slidesPerView: 2,\n    watchSlidesVisibility: true,\n    preloadImages: false,\n    spaceBetween: 30,\n    navigation: true,\n    breakpoints: {\n      768: {\n        slidesPerView: 4,\n        spaceBetween: 20\n      },\n      992: {\n        slidesPerView: 8\n      }\n    },\n    navigation: {\n      nextEl: '.swiper-button-next',\n      prevEl: '.swiper-button-prev'\n    }\n  };\n  Object.assign(brands_swiper_container, swiperParams);\n  brands_swiper_container.initialize();\n  brands_swiper_container.style.opacity = 1;\n}\nconst brands_component_observer = new IntersectionObserver(brandsCallback, {\n  root: null,\n  threshold: 0.1\n});\nbrands_component_observer.observe(brands_component);\nheader_tabs.querySelectorAll('.tab').forEach(tab => {\n  if (window.innerWidth > 767) {\n    tab.addEventListener('mouseenter', function (e) {\n      tab.classList.add('show-tabs');\n    }), tab.addEventListener('mouseleave', function (e) {\n      tab.classList.remove('show-tabs');\n    });\n  }\n});\ncreateApp({\n  setup() {\n    const swiperpartials = ref(null);\n    const swiperm = ref(null);\n    const products = ref([]);\n    const formattedPrice = computed(() => param => {\n      const formatter = new Intl.NumberFormat('it-IT', {\n        style: 'decimal',\n        currency: 'EUR',\n        minimumFractionDigits: 2\n      });\n      return formatter.format(param);\n    });\n    const swiperConf = {\n      slidesPerView: 1.5,\n      centeredSlides: true,\n      spaceBetween: 10,\n      navigation: true,\n      breakpoints: {\n        768: {\n          centeredSlides: false,\n          slidesPerView: 4,\n          spaceBetween: 20\n        }\n      },\n      navigation: {\n        nextEl: '.swiper-button-next .product--item',\n        prevEl: '.swiper-button-prev .product--item'\n      }\n    };\n    onMounted(() => {\n      const callback = (entries, observer) => {\n        entries.forEach(({\n          target,\n          isIntersecting\n        }) => {\n          if (isIntersecting) {\n            download(\"/Products/GetAllProducts\").then(prds => {\n              products.value = prds;\n              Object.assign(swiperm.value, swiperConf);\n              swiperm.value.initialize();\n              observer.unobserve(target);\n            });\n          }\n        });\n      };\n      const obs = new IntersectionObserver(callback, {\n        root: null,\n        threshold: 0.1\n      });\n      obs.observe(swiperpartials.value);\n    });\n    return {\n      products,\n      swiperpartials,\n      swiperm,\n      formattedPrice\n    };\n  }\n}).mount('#partial-products');\n\n//# sourceURL=webpack://net3.1/./wwwroot/js/Page/index.js?");

/***/ }),

/***/ "./wwwroot/js/Page/utilities.js":
/*!**************************************!*\
  !*** ./wwwroot/js/Page/utilities.js ***!
  \**************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

eval("__webpack_require__.r(__webpack_exports__);\n/* harmony export */ __webpack_require__.d(__webpack_exports__, {\n/* harmony export */   \"default\": () => (__WEBPACK_DEFAULT_EXPORT__)\n/* harmony export */ });\nconst utilityFunction = () => {\n  /**\r\n  * Scarica le immagini utilizzando il link selezionato\r\n  */\n  function download(link) {\n    return new Promise((resolve, reject) => {\n      fetch(link).then(res => {\n        if (!res.ok) reject();\n        res.json().then(value => {\n          resolve(value);\n        });\n      }).catch(error => {\n        reject(error);\n      });\n    });\n  }\n  ;\n\n  /**\r\n  * Crea le swiper-slide per l elemento swiper in base ai risultati dell'API, e li inserisce nello swiper-container.\r\n  */\n  function populate(arrayOfValues, container, swiperSlideClass, path) {\n    let divsContainer = [];\n    const slide = document.createElement('swiper-slide');\n    slide.style.height = 'auto';\n    slide.setAttribute('lazy', \"true\");\n    const slide_div = document.createElement('div');\n    slide_div.classList.add(swiperSlideClass, 'h-100');\n    const img = document.createElement('img');\n    img.classList.add('w-100', 'p-2');\n    img.loading = \"lazy\";\n    slide_div.append(img);\n    slide.append(slide_div);\n    arrayOfValues.forEach(el => {\n      const clonedNode = slide.cloneNode(true);\n      clonedNode.querySelector('img').src = `${path}${el.img}`;\n      divsContainer.push(clonedNode);\n    });\n    container.append(...divsContainer);\n  }\n  return {\n    download,\n    populate\n  };\n};\n/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (utilityFunction);\n\n//# sourceURL=webpack://net3.1/./wwwroot/js/Page/utilities.js?");

/***/ })

/******/ 	});
/************************************************************************/
/******/ 	// The module cache
/******/ 	var __webpack_module_cache__ = {};
/******/ 	
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/ 		// Check if module is in cache
/******/ 		var cachedModule = __webpack_module_cache__[moduleId];
/******/ 		if (cachedModule !== undefined) {
/******/ 			return cachedModule.exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = __webpack_module_cache__[moduleId] = {
/******/ 			// no module.id needed
/******/ 			// no module.loaded needed
/******/ 			exports: {}
/******/ 		};
/******/ 	
/******/ 		// Execute the module function
/******/ 		__webpack_modules__[moduleId](module, module.exports, __webpack_require__);
/******/ 	
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/ 	
/************************************************************************/
/******/ 	/* webpack/runtime/define property getters */
/******/ 	(() => {
/******/ 		// define getter functions for harmony exports
/******/ 		__webpack_require__.d = (exports, definition) => {
/******/ 			for(var key in definition) {
/******/ 				if(__webpack_require__.o(definition, key) && !__webpack_require__.o(exports, key)) {
/******/ 					Object.defineProperty(exports, key, { enumerable: true, get: definition[key] });
/******/ 				}
/******/ 			}
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/hasOwnProperty shorthand */
/******/ 	(() => {
/******/ 		__webpack_require__.o = (obj, prop) => (Object.prototype.hasOwnProperty.call(obj, prop))
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/make namespace object */
/******/ 	(() => {
/******/ 		// define __esModule on exports
/******/ 		__webpack_require__.r = (exports) => {
/******/ 			if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 				Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 			}
/******/ 			Object.defineProperty(exports, '__esModule', { value: true });
/******/ 		};
/******/ 	})();
/******/ 	
/************************************************************************/
/******/ 	
/******/ 	// startup
/******/ 	// Load entry module and return exports
/******/ 	// This entry module can't be inlined because the eval devtool is used.
/******/ 	var __webpack_exports__ = __webpack_require__("./wwwroot/js/Page/index.js");
/******/ 	
/******/ })()
;