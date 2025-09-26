<?php
class SessaoUsers
{
    public static function set($email, $senha, $tipo, $idCliente)
    {
        $_SESSION['user_email'] = $email;
        $_SESSION['user_senha'] = $senha;
        $_SESSION['user_tipo'] = $tipo;
        $_SESSION['user_idCliente'] = $idCliente;
    }
    public static function getIdCliente()
    {
        return $_SESSION['user_idCliente'] ?? null;
    }

    public static function getEmail()
    {
        return $_SESSION['user_email'] ?? null;
    }

    public static function getTipo()
    {
        return $_SESSION['user_tipo'] ?? null;
    }

}

class NewUsers
{
    public static function setType($tipo)
    {
        $_SESSION['newuser_tipo'] = $tipo;
    }

    public static function getTipo()
    {
        return $_SESSION['newuser_tipo'] ?? null;
    }
}

class Carrinho
{
    public static function set($produtos)
    {
        $_SESSION['Produtos'] = $produtos;
    }
    public static function getProdutos()
    {
        return $_SESSION['Produtos'] ?? null;
    }

}

?>