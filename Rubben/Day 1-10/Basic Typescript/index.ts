// Tipe data string
let nama: string = "Rubben Mulyo Santoso"

//Tipe Data Number
let absen: number = 30

// Tipe Data Boolean
let nafas: boolean = true

//Tipe Data any
let hidup: any = true

//Null
let data: null = null

// Array
let jurusan: string[] = ["PPLG", "DKV", "TJKT"]

// Read only Array 
const kelamin: ReadonlyArray<string> = ["Laki Laki", "Perempuan"]

//Tuple 
let person: readonly [string, string, number] = ["Rubben", "Mulyo", 30]

//Union type
let coba: string | number = "sample"
coba = 12

// Tipe data string
console.info("Nama:", typeof nama, nama);
