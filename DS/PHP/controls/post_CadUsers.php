<?php
if ($_POST) {
    if (isset($_POST['btnCadUser'])) {
        require_once 'funcoes.php';
        require_once '../models/dados.php';
        session_start();
        $nome = $_POST['txtNome'];
        $cpf = $_POST['txtCpf'];
        $tel = $_POST['txtTel'];
        $end = $_POST['txtEnd'];
        $endNum = $_POST['txtEndNum'];
        $email = $_POST['txtEmail'];
        $senha = $_POST['txtSenha'];
        // se email nao existir
        // se cpf ja existir e users id = 1, cad users e update clie
        // se nao CAD USERS CAD CLIE
        // se nao avisa que o email ja esta sendo usado
        if (Querys::emailUsersExists($email)) {
            include '../views/CadUsers.php';
            echo 'EMAIL EXISTENTE';
            exit;
        }

        if (Querys::CpfExists($cpf)) {
            if (Querys::ehDefault($cpf)) {
                // CPF existe e é default criar user e atualizar cliente
                if (SessaoUsers::getTipo() == 'ADMIN') {
                    // nao deixa criar users se for admin
                    Inserts::UpdateClie($nome, $cpf, $tel, $end, $endNum, 1);
                } else {
                    // user normal riar user e atualizar cliente
                    $idUser = Inserts::CadUsers($email, $senha);
                    Inserts::UpdateClie($nome, $cpf, $tel, $end, $endNum, $idUser);
                }
                exit;
            } else {
                // QUANDO CPF JA EXISTE E O CLIENTE JA FEZ CADSTRO UMA VEZ
                include '../views/CadUsers.php';
                echo 'CPF JA EXISTENTE! TENTE LOGIN!';
                exit;
            }
        } else {
            // CPF não existe cria user e cliente
            if (SessaoUsers::getTipo() == 'ADMIN') {
                // nao deixa criar users E cadastra no defualt
                Inserts::CadClie($nome, $cpf, $tel, $end, $endNum, 1);
                exit;
            } else {
                // CADASTRO NORMAL DO CLIENTE
                $idUser = Inserts::CadUsers($email, $senha);
                Inserts::CadClie($nome, $cpf, $tel, $end, $endNum, $idUser);
                        header('Location: ../views/index.php');
                        exit;
            }
        }
    }
    if (isset($_POST['btnVoltar'])) {
        header("Location: ../views/index.php");
        exit;
    }
}

?>