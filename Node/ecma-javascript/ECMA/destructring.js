// const PI = Math.PI;
// const E - Math.E; -- Natural Logarithms
// const SQRT2 = Math.SQRT2;

const { PI, E, SQRT2 } = Math;

//Function example

const circle = {
    label: 'circleX',
    radius: 2,
}

const circleArea = ({radius}) => (PI * radius * radius).toFixed(2);

console.log(circleArea(circle));

const [first, ...restOfThem] = [1, 2, 3, 4, 5];
console.log(restOfThem);