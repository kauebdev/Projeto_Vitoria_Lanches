<?php
class bd {
    public static function ConectarBanco() {
        require_once '../models/Config.php';

        // Criação da conexão
        $conn = new mysqli( connection::$host, connection::$user, connection::$password, connection::$database);

        // Verifica se houve erro na conexão
        if ($conn->connect_error) {
            die("Erro na conexão: " . $conn->connect_error);
        }

        // Define o charset para evitar problemas com caracteres especiais
        $conn->set_charset("utf8mb4");

        return $conn;
    }
}

class Tratamento {
    public static function LoginExists($email, $senha) {
        require_once '../models/dados.php';

        $conn = bd::ConectarBanco();
        $sql = "SELECT * FROM TB_USERS 
                WHERE TB_USERS_EMAIL = '$email'
                and TB_USERS_SENHA = '$senha'";
        $result = $conn->query($sql);
        $row = $result->fetch_assoc();

        // se existir 
        if ($row) {
            // inicio imnha sessao
            session_start();
            SessaoUsers::set($row["TB_USERS_EMAIL"], $row["TB_USERS_SENHA"], $row["TB_USERS_TIPO"]);
            header('Location: ../views/MainMenu.php');
            exit;
        } else {
            include '../views/index.php';
            echo 'LOGIN OU SENHA INCORRETOS';
        }

        $result->close();
        $conn->close();
    }
}
?>