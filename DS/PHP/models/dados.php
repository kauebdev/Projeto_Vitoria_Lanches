<?php
class SessaoUsers {
    public static function set($email, $senha, $tipo) {
        $_SESSION['Email'] = $email;
        $_SESSION['Senha'] = $senha;
        $_SESSION['Tipo']  = $tipo;
    }

    public static function getEmail() {
        return $_SESSION['Email'] ?? null;
    }

    public static function getTipo() {
        return $_SESSION['Tipo'] ?? null;
    }
}
?>