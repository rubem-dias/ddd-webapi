export interface IDuck {
    name: string
    numLegs: number;
    age: number;
    makeSound?: (sound: string) => void;
}

const duck1: IDuck = {
    name: 'huey',
    numLegs: 2,
    age: 10,
    makeSound: (sound: any) => console.log(sound)
}
const duck2: IDuck = {
    name: 'jhoe',
    numLegs: 2,
    age: 1,
    makeSound: (sound: any) => console.log(sound)
}

export const ducks = [duck1, duck2]