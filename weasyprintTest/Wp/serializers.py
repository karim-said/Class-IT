from rest_framework import serializers

from .models import WashMachine

class WashMachineSerializer(serializers.ModelSerializer):
    class Meta:
        model = WashMachine
        field = '__all__'