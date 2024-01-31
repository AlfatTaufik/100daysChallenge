<?php
function solution($numbers) {
    $arr = str_split((string)$numbers);
    $angka = 0;
    foreach($arr as $item) {
        $angka += pow($item,count($arr));
    }
    return $angka;
}

echo solution(123); // 1^3 = 1; 2^3 = 8; 3^3 = 18 => 1+8+27 = 36
