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


    return {
        download
        }
}

export default utilityFunction;