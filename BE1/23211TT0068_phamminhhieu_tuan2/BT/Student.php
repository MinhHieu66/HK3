<?php
class Student extends User
{
    private $gpa;

    function __construct($username, $password, $firstname, $lastname, $gpa)
    {
        parent::__construct($username, $password, $firstname, $lastname);
        $this->gpa = $gpa;
    }

    public function getGpa()
    {
        return $this->gpa;
    }

    public function setGpa($gpa)
    {
        $this->gpa = $gpa;
    }


    public function classify()
    {
        if ($this->gpa < 5) return "Yeu";
        else if ($this->gpa < 7) return "Trung binh";
        else if ($this->gpa < 8) return "Kha";
        else return "Gioi";
    }
}
