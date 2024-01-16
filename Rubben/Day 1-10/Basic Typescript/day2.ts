// Function 
function kali(a: number, b:number) {
    return a * b
}
function print(): void {
    console.log("Hello from function")
}

//Type Alias bisa & interface

type Person = {
    name: string;
    age?: number;

}
interface Sekolah {
    name: string;
    alamat: number;

}
let people: Person = {
    name: "Rubben",
}

