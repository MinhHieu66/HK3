<?php
class User
{
    private $username;
    private $password;
    private $firstname;
    private $lastname;

    function __construct($username, $password, $firstname, $lastname)
    {
        $this->username = $username;
        $this->password = password_hash($password, PASSWORD_DEFAULT);
        $this->firstname = $firstname;
        $this->lastname = $lastname;
    }

    public function getFullname()
    {
        return $this->firstname . " " . $this->lastname;
    }

    public function getUsername()
    {
        return $this->username;
    }

    public static function login($username, $password)
    {
        $hash = password_hash("12345", PASSWORD_DEFAULT);
        if ($username = "admin" && password_verify($password, $hash)) return true;
        return false;
    }
}
