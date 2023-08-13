import Entity from './entity'

export default class AnthropometricMeasurement extends Entity<number>{
    shoulderHeight: number;
    chestWidth: number;
    humpGirth: number;
    liveWeight: number;
    camelLength: number;
    bmi: number;
    fatRatioCoefficient: number;
    muscleWeight: number;
    camelId: number | undefined;
}