<?php

function remove(string $s): string{
    $arrStr = explode(' ', $s);
    $proccess = array_map(fn ($n) => rtrim($n, '!'), $arrStr);
    $result = implode(' ', $proccess);
    return $result;
}

var_dump(remove("Hi!")); // Hi
var_dump(remove("Hi!!")); // Hi
var_dump(remove("!Hi")); // !Hi
var_dump(remove("!Hi!")); // !Hi

// hapus semua tanda seru di akhir kata