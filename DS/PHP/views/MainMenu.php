<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <center>
        <?php
        require_once '../models/dados.php';
        session_start();
        echo 'EMAIL: ' . SessaoUsers::getEmail() . '<br>';
        echo 'TIPO: ' . SessaoUsers::getTipo();
            if (SessaoUsers::getTipo() == 'ADMIN') {
                echo '<h1>admin</h1>';           
             } else {
                    echo '<h1>cliente</h1>';           

                }
        ?> 


    </center>
</body>
</html>