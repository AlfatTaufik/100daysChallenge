<?php

function divisors($n){
    $dividers = 0;
    for ($i = $n; $i > 0; $i--) {
        if ($n % $i == 0) {
            $dividers++;
        }
    }
    return $dividers;
}

var_dump(divisors(11)); // 2 -> 1, 11
var_dump(divisors(30)); // 8 -> 1, 2, 3, 5, 6, 10, 15, 30