var localeComputer = document.getElementById('locale')
var graus = document.getElementById('graus')
var icon = document.getElementById('iconweather')
var icontemperature = document.getElementById('icontemperatureCelcius')

const setCoordLocalStorage = (latitude, longitude) => {
    localStorage.setItem('latitude', latitude)
    localStorage.setItem('longitude', longitude)
}

navigator.geolocation.getCurrentPosition((position) => {
    //user granted permission
    const latitude = position.coords.latitude
    const longitude = position.coords.longitude

    if (localStorage.latitude == undefined || localStorage.longitude == undefined) {
        setCoordLocalStorage(latitude, longitude)
    }

    if (localStorage.latitude != latitude || localStorage.longitude != longitude) {

        localStorage.removeItem.latitude
        localStorage.removeItem.longitude

        setCoordLocalStorage(latitude, longitude)
    }

    let key = '85fd1b4f64ade39ca9b0d5dee59c97ca';
    fetch(`https://api.openweathermap.org/data/2.5/weather?lat=${latitude}&lon=${longitude}&appid=${key}`)
        .then((resp) => { return resp.json() })
        .then((data) => {
            console.log(data)
            localeComputer.innerText = data.name;
            graus.innerText = Math.round(data.main.temp - 273.15);
            var geticon = data.weather[0].icon
            var newimg = `https://openweathermap.org/img/wn/${geticon}@2x.png`;
            icon.src = newimg
        })
        .catch(function () {

        })

}, () => {
        //user denied permission
        localeComputer.innerText = 'Localização Bloqueada! - Permita a localização na página.'
        graus.innerText = ''
        icontemperature.setAttribute('class', '')
})