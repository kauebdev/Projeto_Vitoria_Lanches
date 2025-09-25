<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cadastro</title>
</head>
<?php
require_once '../models/dados.php';
session_start();
NewUsers::setType('CLIENTE');

if (SessaoUsers::getTipo() == 'ADMIN'){
    echo"teste";
}
?>

<body>
    <center>
        <h1>Cadastre-se</h1>

        <form action="../controls/post_CadUsers.php" method="post">
            digite seu nome: <input type="text" name="txtNome" required> <br><br>
            digite seu cpf: <input type="text" name="txtCpf" required><br><br>
            digite seu telefone: <input type="tel" name="txtTel" required><br><br>
            digite seu endereço: <input type="text" name="txtEnd" required>
            N°: <input type="number" name="txtEndNum" required><br><br>
            !! se for admin nao APARECE ISSO AQUI  EM BAIXO !!<br><br>
            digite seu email de login: <input type="email" name="txtEmail" required><br><br>
            digite sua senha: <input type="password" name="txtSenha" required><br><br>

            <input type="submit" value="Confirmar" name="btnCadUser"><br><br>

        </form>
        <form action="../controls/post_CadUsers.php" method="post">
            <input type="submit" value="voltar" name="btnVoltar">
        </form>
    </center>
</body>

</html>