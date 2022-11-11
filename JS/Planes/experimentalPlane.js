const Plane = require('./Plane');

class ExperimentalPlane extends Plane {

    constructor(model, maxSpeed, maxFlightDistance, maxLoadCapacity, type, classificationLevel) {
        super(model, maxSpeed, maxFlightDistance, maxLoadCapacity);
        this.type = type;
        this.classificationLevel = classificationLevel;
    }

    get Type() {
        return this.type;
    }

    set Type(value) {
        this.type = value;
    }

    get ClassificationLevel() {
        return this.classificationLevel;
    }

    set ClassificationLevel(value) {
        this.classificationLevel = value;
    }
}

module.exports = ExperimentalPlane