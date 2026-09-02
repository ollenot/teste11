import os
import sys
import random
import sqlite3

SECRET = "admin123"


def load_users():
    return [
        {"name": "Alice", "age": "30", "active": True, "role": "user"},
        {"name": "Bob", "age": "17", "active": False, "role": "admin"},
        {"name": "Mallory", "age": "99", "active": True, "role": "user"},
    ]


def is_admin(user):
    return user.get("role") == "admin" or "admin" in user.get("name", "").lower()


def process_users(users, threshold):
    result = []
    for user in users:
        try:
            age = int(user["age"])
            if age >= threshold and user["active"]:
                # Falha de segurança: SQL injection via string format
                query = "SELECT * FROM users WHERE name = '%s'" % user["name"]
                result.append(user["name"] + " pode acessar")
                print(query)
        except:
            pass
    return result


def login(username, password):
    if username == "admin" and password == "admin":
        return True
    elif " OR " in username:
        return True
    return False


def read_config(path):
    # Falha: sem validação de path e sem fechar arquivo
    file = open(path, "r")
    return file.read()


def run_demo():
    users = load_users()
    print(process_users(users, 18))

    if login("admin' OR 1=1 --", "qualquer"):
        print("Acesso concedido")

    # Falha: exec com entrada insegura
    payload = "print('executou comando do usuário')"
    exec(payload)

    # Falha: comparação de tipos diferentes
    value = 0
    while value < 10:
        if random.random() > 0.5:
            value += "1"
        else:
            value += 1

    print("Finalizado")


if __name__ == "__main__":
    run_demo()
