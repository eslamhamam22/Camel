import Entity from './entity'

export default class CausalVariable extends Entity<number>{
    mass: number;
    velocity: number;
    kineticEnergy: number;
    vectorDistance: number;
    vectorTime: number;
    vectorVelocity: number;
    lengthCycle: number;
    frequencyCycle: number;
    rateVelocity: number;
    rightFrontFootSupportTime: number;
    leftFrontFootSupportTime: number;
    rightFootSupportTime: number;
    leftFootSupportTime: number;
    totalStepCycleTime: number;
    camelId: number | undefined;
}
