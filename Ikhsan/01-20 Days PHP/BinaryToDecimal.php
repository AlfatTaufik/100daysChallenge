<?php 

function binaryToDec($arr) {
    $binary = implode("", $arr);
    return bindec($binary);
}

var_dump(binaryToDec(['0','0','1','0'])); // 2
var_dump(binaryToDec(['0','1','1','1'])); // 7

?>