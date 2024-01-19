<?php 
function detect_pangram($string) { 
    $abc = range('a', 'z');
    foreach($abc as $s) {
      if(strpos(strtolower($string), $s) === false) {
        return false;
      }
    }
    
    return true;
}

var_dump(detect_pangram('Jika metafora syair Zubaidah apik, cegah rival Wali naik Qantas ke Xian'));
// true

/*
Pangram adalah kalimat yang berisi setiap huruf alfabet (a-z) minim satu kali.
*/
?>