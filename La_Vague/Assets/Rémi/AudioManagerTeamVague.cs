﻿
using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManagerTeamVague : MonoBehaviour
{

	public static AudioManagerTeamVague instance;

	public AudioMixerGroup mixerGroup;

	public SoundTeamVague[] sounds;

	public string naame;
	public void Start()
	{
		Play("Musicyi");
	}

	public void Update()
	{
		if (SceneManager.GetActiveScene().name == naame)
		{
			Destroy(gameObject);
		}
	}

	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		foreach (SoundTeamVague s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.loop = s.loop;

			s.source.outputAudioMixerGroup = mixerGroup;
		}
	}

	public void Play(string sound)
	{
		SoundTeamVague s = Array.Find(sounds, item => item.name == sound);
		if (s == null)
		{
			Debug.LogWarning("Sound: " + name + " not found!");
			return;
		}

		s.source.volume = s.volume * (1f + UnityEngine.Random.Range(-s.volumeVariance / 2f, s.volumeVariance / 2f));
		s.source.pitch = s.pitch * (1f + UnityEngine.Random.Range(-s.pitchVariance / 2f, s.pitchVariance / 2f));

		s.source.Play();
	}

}

