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
    public static function Clear(){
        $_SESSION['Produtos'] = [];
    }
    public static function set($produtos)
    {
        $_SESSION['Produtos'] = $produtos;
    }
    public static function getProdutos()
    {
        return $_SESSION['Produtos'] ?? null;
    }

}

class Prod {
    public static function set($IdProd, $nome, $Idtipo, $preço, $desc)
    {
        $_SESSION['prod_Id'] = $IdProd;
        $_SESSION['prod_nome'] = $nome;
        $_SESSION['prod_Idtipo'] = $Idtipo;
        $_SESSION['prod_preco'] = $preço;
        $_SESSION['prod_desc'] = $desc;
    }
        public static function getId()
    {
        return $_SESSION['prod_Id'] ?? null;
    }

    public static function getNome()
    {
        return $_SESSION['prod_nome'] ?? null;
    }

    public static function getIdTipo()
    {
        return $_SESSION['prod_Idtipo'] ?? null;
    }

    public static function getPreco()
    {
        return $_SESSION['prod_preco'] ?? null;
    }

        public static function getDesc()
    {
        return $_SESSION['prod_desc'] ?? null;
    }
}

?>