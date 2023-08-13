import Entity from './entity'
import AnthropometricMeasurement from './anthropometric'
import MechanicalMeasurement from './mechanical'
import CausalVariable from './causal'

export default class Camel extends Entity<number>{
    video:string;
    description:string;
    mechanical: MechanicalMeasurement;
    anthropometric: AnthropometricMeasurement;
    causal: CausalVariable;
}