<?php
// function findShort($str){
//     $words = explode(' ', $str);

//     $minLength = strlen($words[0]);

//     foreach ($words as $word) {
//         $minLength = min($minLength, strlen($word));
//     }

//     return $minLength;
// }

function findShort($str){
    return min(array_map('strlen', (explode(' ', $str))));
}

var_dump(findShort('jika maka iya no lur')); // 2
var_dump(findShort('Joko beli buah di pasar Bondalem')); // 2
var_dump(findShort('Cipto plgn dgn pcr baru')); // 3