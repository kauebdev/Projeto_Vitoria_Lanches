<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Vitoria Lanches</title>
</head>
<?php
require_once '../models/dados.php';
session_start();
SessaoUsers::set(null,null,'CLIENTE', null)
?>
    <body>
        <Center>
            <!-- mudra para post posteriomente -->
            <form action="../controls/post_index.php" method="post">
                    Login: <input type="email" name="txtEmail" placeholder="Digite o Email" required>
                    Senha: <input type="password" name="txtSenha" placeholder="Digite a senha" required>
                    <br>
                    <br>
                    <input type="submit" name="btnLogin" value="LOGIN"> 
                   
                    <input type="submit" name="btnCad" value="CADASTRAR" formnovalidate>
            </form>
        </Center>
    </body>

</html>