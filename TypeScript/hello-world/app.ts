//Normal string
var mensagem:string = 'Hello there.';
console.log(mensagem);

//String array
let animals: Array<string> = ['Cat','Dog'];
console.log(animals);

//Object
let pokemon: {
    name: string,
    type: string,
    category: string
}

pokemon = { name: 'Bulbasaur', type: 'Grass', category: 'Seed'};
console.log(pokemon);

//Function
function multiply(num1: number, num2:number): number{
    return num1 + num2;
}
console.log(multiply(1,2));

//Boolean
let finished: boolean = false;

if(finished)
    console.log('Task finished.');
else
    console.log('Task incomplete.');

//Bigint
let bigInt: bigint = 787979879879879987987n;
console.log(bigInt);

//Tuple

let person: [string, string, number] = ['Ítalo', 'Henrique', 26];
console.log(person);

console.log(person[1]);
