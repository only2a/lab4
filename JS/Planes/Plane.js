class Plane {

    constructor(model, maxSpeed, maxFlightDistance, maxLoadCapacity) {
        this.model = model;
        this.maxSpeed = maxSpeed;
        this.maxFlightDistance = maxFlightDistance;
        this.maxLoadCapacity = maxLoadCapacity;
    }

    get Model() {
        return this.model;
    }

    set Model(value){
        this.model=value;
    }

    get MaxSpeed() {
        return this.maxSpeed;
    }

    set MaxSpeed(value){
        this.maxSpeed=value;
    }

    get MaxFlightDistance() {
        return this.maxFlightDistance;
    }

    set MaxFlightDistance(value){
        this.maxFlightDistance=value;
    }

    get MaxLoadCapacity() {
        return this.maxLoadCapacity;
    }

    set MaxLoadCapacity(value){
        this.maxLoadCapacity=value;
    }
}

module.exports = Plane;