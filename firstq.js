// adding fractions given string (??) int put it in indivisble form - key muhammad coding asssesment

const gcd = (x, y) => {
    if (x == 0)
    return y;
    return gcd(y % x, x);
}
 
const indivisble = (d3, n3) => {
    let lcm = gcd(n3, d3);
    d3 = parseInt(d3 / lcm);
    n3 = parseInt(n3 / lcm);
    return `${n3} / ${d3}`;
}
 
function solution(n1, d1, n2, d2) {
 let d3 = gcd(d1, d2);
 d3 = (d1 * d2) / d3;
 let n3 = ((n1) * (d3 / d1) + (n2) * (d3 / d2));
 indivisble(d3, n3);
}

// let n1 = 7;
// let d1 = 10; 
// let n2 = 13;
// let d2 = 10; 
 
console.log(solution(n1, d1, n2, d2));

 