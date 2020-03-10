var localeComputer = document.getElementById('locale')
var graus = document.getElementById('graus')
var icon = document.getElementById('iconweather')

function getCoordenadas(position) {
    let latitude = (position.coords.latitude)
    let longitude = (position.coords.longitude)

    localStorage.setItem("latitude", latitude)
    localStorage.setItem("longitude", longitude)
}

function getTemperatura(latitude, longitude) {
    let key = '85fd1b4f64ade39ca9b0d5dee59c97ca';
    fetch(`https://api.openweathermap.org/data/2.5/weather?lat=${latitude}&lon=${longitude}&appid=${key}`)
        .then(function (resp) { return resp.json() })
        .then(function (data) {
            console.log(data)
            localeComputer.innerText = data.name;
            graus.innerText = Math.round(data.main.temp - 273.15);
            var geticon = data.weather[0].icon
            var newimg = `https://openweathermap.org/img/wn/${geticon}@2x.png`;
            icon.src = newimg
            console.log(newimg)
            console.log(icon)
        })
        .catch(function () {

        })
}

if (localStorage.latitude == undefined && localStorage.longitude == undefined) {
    navigator.geolocation.getCurrentPosition(function (position) {
        //PERMITE LOCALIZAÇÃO
        navigator.geolocation.getCurrentPosition(getCoordenadas);
        setTimeout(() => {
            getTemperatura(localStorage.latitude, localStorage.longitude)
        }, 5000);
    }, function () {
        //NEGA LOCALIZAZÃO
    });
} else {
    getTemperatura(localStorage.latitude, localStorage.longitude)
}
