from flask import Flask, jsonify, request

app = Flask(__name__)

# Исходные данные для телевизора
tv_data = {
    "Name": "Samsung",
    "Status": False,
    "InputMode": {"Name": "VGA", "available": ["HDMI", "VGA", "USB"]},
    "Tuner": {"Name": "", "Model": ""},
    "Channel": {"Number": 1, "Name": "каналы"},
    "Volume": 20,
}

# Эндпоинт для получения текущего состояния телевизора
@app.route('/tv', methods=['GET'])
def get_tv_status():
    return jsonify(tv_data)

# Эндпоинт для управления состоянием телевизора
@app.route('/tv', methods=['POST'])
def control_tv():
    if not request.is_json:
        return jsonify({"error": "Данные должны быть в формате JSON"}), 400

    data = request.json

    if "action" not in data:
        return jsonify({"error": "Отсутствует действие в запросе"}), 400

    action = data["action"]

    # Обработка команд для управления телевизором
    if action == "power":
        tv_data["Status"] = not tv_data["Status"]
    elif action == "volume_up":
        tv_data["Volume"] += 1
    elif action == "volume_down":
        tv_data["Volume"] -= 1
    elif action == "mute":
        tv_data["Volume"] = 0
    elif action == "change_input":
        if "input_mode" in data:
            input_mode = data["input_mode"]
            if input_mode in tv_data["InputMode"]["available"]:
                tv_data["InputMode"]["Name"] = input_mode
            else:
                return jsonify({"error": "Недопустимый режим ввода"}), 400
        else:
            return jsonify({"error": "Отсутствует режим ввода в запросе"}), 400
    elif action == "change_channel":
        if "channel_number" in data:
            tv_data["Channel"]["Number"] = data["channel_number"]
        else:
            return jsonify({"error": "Отсутствует номер канала в запросе"}), 400
    elif action == "set_tuner":
        if "tuner_name" in data and "tuner_model" in data:
            tv_data["Tuner"]["Name"] = data["tuner_name"]
            tv_data["Tuner"]["Model"] = data["tuner_model"]
        else:
            return jsonify({"error": "Отсутствует имя или модель тюнера в запросе"}), 400
    else:
        return jsonify({"error": "Неизвестное действие"}), 400

    return jsonify(tv_data)

if __name__ == '__main__':
    app.run(debug=True)
