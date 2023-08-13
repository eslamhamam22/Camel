import Entity from './entity'

export default class MechanicalMeasurement extends Entity<number>{
    totalWeight: number;
    strokeDistance: number;
    work: number;
    strokTime: number;
    genralAbility: number;
    velocity: number;
    gravity: number;
    mass: number;
    lengthCycle: number;
    initialVelocityTime: number;
    finalVelocityTime: number;
    acceleration: number;
    motionAmount: number;
    motionEnergy: number;
    camelId: number | undefined;
}
