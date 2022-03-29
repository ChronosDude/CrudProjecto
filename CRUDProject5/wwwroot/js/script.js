function initMap() {
    let lugarinfo = []
    const ubicacion = new Localizacion(() => {
        const coordenadas = {
            lat: ubicacion.latitude,
            lng: ubicacion.longitude,
            
        }
        const options = {
            center: coordenadas,
            zoom: 14,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        }

        var mapa = new google.maps.Map(document.getElementById("map"), options);
        var marker = new google.maps.Marker({
            position: coordenadas,
            map: mapa,
            draggable: true,
            title: "Drag me!"
        });

        var myElement = document.getElementById("latitud");
        myElement.value = String(coordenadas.lat);
        var event = new Event('change');
        myElement.dispatchEvent(event);

        var myElement = document.getElementById("longitud");
        myElement.value = String(coordenadas.lng);
        var event = new Event('change');
        myElement.dispatchEvent(event);

        marker.addListener('dragend', function (event) {

            var myElement = document.getElementById("latitud");
            myElement.value = String(this.getPosition().lat());
            var event = new Event('change');
            myElement.dispatchEvent(event);

            var myElement = document.getElementById("longitud");
            myElement.value = String(this.getPosition().lng());
            var event = new Event('change');
            myElement.dispatchEvent(event);
            
        });
    });
}

function imprimir(dato) {
    var myElement = document.getElementById("nombre");
    myElement.value = String(dato);
    var event = new Event('change');
    myElement.dispatchEvent(event);
}

function getMap(datos) {
    let lugarinfo = []
    const ubicacion = new Localizacion(() => {
        const coordenadas = {
            lat: ubicacion.latitude,
            lng: ubicacion.longitude
        }
        const options = {
            center: coordenadas,
            zoom: 14,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        }

        var mapa = new google.maps.Map(document.getElementById("getmap"), options);

        datos.forEach(x => {
            return new google.maps.Marker({
                title: x.ubicacion,
                position: { lat: x.latitud, lng: x.longitud },
                map: mapa
            });
        })


    });
}



function getMapById(dato) {
    const coordenadas = {
        lat: parseFloat(dato.latitud),
        lng: parseFloat(dato.longitud)
    }
    const options = {
        center: coordenadas,
        zoom: 14,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    }

    var mapa = new google.maps.Map(document.getElementById("getmapbyid"), options);
    var marker = new google.maps.Marker({
        position: coordenadas,
        title: dato.ubicacion,
        map: mapa,
        draggable: true,

    });
    marker.addListener('dragend', function (event) {

        var myElement = document.getElementById("latitud");
        myElement.value = String(this.getPosition().lat());
        var event = new Event('change');
        myElement.dispatchEvent(event);

        var myElement = document.getElementById("longitud");
        myElement.value = String(this.getPosition().lng());
        var event = new Event('change');
        myElement.dispatchEvent(event);

    });

    marker.addListener("click", () => {
        infoWindow.close();
        infoWindow.setContent(marker.getTitle());
        infoWindow.open(marker.getMap(), marker);
    });

    
}

