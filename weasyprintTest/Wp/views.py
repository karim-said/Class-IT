from .models import WashMachine
from django.http import JsonResponse
from django.views.decorators.csrf import csrf_exempt
from django.core.exceptions import ObjectDoesNotExist
from django.views.decorators.http import require_http_methods

from rest_framework.decorators import authentication_classes, permission_classes
from rest_framework.authentication import BasicAuthentication
from rest_framework.permissions import IsAuthenticated

from django.views.decorators.csrf import csrf_exempt
import json


def get_view(request):
    data_from_db = WashMachine.objects.values()

    data_list = list(data_from_db)
    return JsonResponse(data_list,safe=False)

@csrf_exempt
def post_view(request):
    if request.method == 'POST':
        try:
            # Получение JSON-данных из тела запроса
            data = json.loads(request.body)
            
            
            # Создание объекта WashMachine
            wash_machine = WashMachine.objects.create(
                name=data.get("name"),
                state=data.get('state'),
                mode=data.get('mode')
                # Добавьте другие поля, если необходимо
            )

            return JsonResponse({'status': 'success', 'wash_machine_id': wash_machine.id})
        except Exception as e:
            return JsonResponse({'status': 'error', 'message': str(e)}, status=500)
    else:
        return JsonResponse({'status': 'error', 'message': 'Метод запроса должен быть POST.'}, status=400)
    
def get_view_id(request, wm_id):
    if request.method == 'GET':
        try:
            # Получение объекта Projector по id
            washmacine = WashMachine.objects.get(id=wm_id)
            data = {
                'id': washmacine.id,
                'name': washmacine.name,
                'state': washmacine.state,
                'mode':washmacine.mode
            }
            return JsonResponse(data)
        except WashMachine.DoesNotExist:
            return JsonResponse({'error': 'Washmascine с указанным id не найден.'}, status=404)
    else:
        return JsonResponse({'status': 'error', 'message': 'Метод запроса должен быть GET.'}, status=400)





@csrf_exempt
def view_update(request, wm_id):
    if request.method == 'PUT':
        try:
            washmachine = WashMachine.objects.get(id=wm_id)
            data = json.loads(request.body)

            washmachine.name = data.get('name', washmachine.name)
            washmachine.state = data.get('state', washmachine.state)
            washmachine.mode = data.get('mode', washmachine.mode)
            washmachine.save()

            return JsonResponse({"success": "Update successful"})
        except ObjectDoesNotExist:
            return JsonResponse({"error": "WashMachine not found"}, status=404)
        except json.JSONDecodeError:
            return JsonResponse({"error": "Invalid JSON in request body"}, status=400)
        except Exception as e:
            return JsonResponse({"error": str(e)}, status=500)
    else:
        return JsonResponse({'status': 'error', 'message': 'Метод запроса должен быть PUT.'}, status=400)    

def view_delete(request,wm_id):
        try:
            washmachine = WashMachine.objects.get(id = wm_id)
            washmachine.delete()
            return JsonResponse({"success":"deleted successfully"})
        except Exception as e:
                return JsonResponse({"error": str(e)}, status=500)


def view_turnOn(request,wm_id):
    if request.method == 'POST':
        try:
            washmachine = WashMachine.objects.get(id = wm_id)
            washmachine.state = not washmachine.state
            washmachine.save()
            return JsonResponse({"success":"successfully"})
        except Exception as e:
                return JsonResponse({"error": str(e)}, status=404)
    else:
        return JsonResponse({'status': 'error', 'message': 'Метод запроса должен быть PUT.'}, status=400)