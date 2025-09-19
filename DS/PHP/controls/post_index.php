<?php
if ($_POST){
    require_once 'funcoes.php';

    if (isset($_POST['btnLogin'])){
        $email = $_POST['txtEmail'];
        $senha = $_POST['txtSenha'];
        Tratamento::LoginExists($email,$senha);
    }

    
    if (isset($_POST['btnCad'])){
        
    }
}
?>