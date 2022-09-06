using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class AndroidNotifications : MonoBehaviour
{
   


    private void Start()
    {
        AndroidNotificationCenter.CancelAllDisplayedNotifications();
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Notifcations Channel",
            Importance = Importance.Default,
            Description = "Reminder notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);
       
    }

    private void OnApplicationFocus(bool focus)
    {
        if(focus == false)
        {
            //crear la notificacion
            var hungerNotification = new AndroidNotification();
            hungerNotification.Title = "Vuelve! tu peludo te necesita";
            hungerNotification.Text = "Tu  perrito esta hambriento, ve a darle su alimento";
            hungerNotification.FireTime = System.DateTime.Now.AddSeconds(10);
            //enviar notificación
            AndroidNotificationCenter.SendNotification(hungerNotification, "channel_id");
        }
       
    }

}
