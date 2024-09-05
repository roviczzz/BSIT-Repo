<?php
echo "Programmed by : Rodriguez, Rovic M.\n";
echo "BIT33\n";
echo "Date Today : September 5, 2024\n\n\n";

$fname = readline("Provide Fullname : ");
$CYS = readline("CYS : ");
$prelim = readline("Input Prelim Grade : ");
$midTerm = readline("Input Midterm Grade : ");
$finalTerm = readline("Input Final Term Grade : ");
$finalGrade = ($prelim + $midTerm + $finalTerm) / 3;

echo "\n\n";
echo "Student Fullname : " .$fname ."\n";
echo "CYS : " .$CYS ."\n";
echo "Prelim Grade : " .$prelim ."\n";
echo "Midterm Grade : " .$midTerm ."\n";
echo "Final Term Grade : " .$finalTerm ."\n";
echo "Final Grade is : " .$finalGrade ."\n";