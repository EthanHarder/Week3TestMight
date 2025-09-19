# Week3TestMight

Ethan Harder - 100877874
No major issues with the repository, but my method from last week of doing the unity and github in parallel messed up, so i had to push twice. weird but not a problem.

My main feedback for myself was for redundant components. adding projectiles to the game was not relevant to the task for this exercise, and took a lot of time I really didnt need to use.

The Singleton implementation I chose was for a sort of 'Pause Manager'. The singleton is checked by the player and the projectiles, and they wont move or recieve inputs if the game is paused. This was, pausing is only done in one section, and i wont accidentally pause one object and not another.

The Factory implementation was not for enemies but rather just for 'objects'. the abstract enemy had a trigger function that specifically tests if the player touched it, and I expanded this into an enemy and a collectable fruit. The spawner abstract just spawns their gameObject on Start, and the enemy and fruit spawners were for their respective offshoot of 'object'. For this simplistic case they only spawn their contents on Start, but this system would happily expand to spawn them over time or over the level progress.

<img width="464" height="522" alt="image" src="https://github.com/user-attachments/assets/ce655b49-76d0-4e94-922e-70e1b16f4f37" />

My flowchart came out okay. Im still not completely sure on how to illustrate a simple 'if'. I think a decision diamond? if the else case just returns, i dont have a case for that, but I think the diagram still makes sense.

My only problem would probably be the layout of the graphs. since they are seperate, I probably should have lined them up and had them all go top -> bottom. But refining was difficult with the provided time.

All in all, I think it came out well. my current priority is probably learning how to use unity2D. i just kinda misused 3d to make this project. hopefully ill figure it out. 100/100 self-reflection because I think I did really well, even if the projectiles werent a great use of time.
