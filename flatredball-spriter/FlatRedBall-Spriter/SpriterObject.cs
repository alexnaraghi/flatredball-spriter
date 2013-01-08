﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlatRedBall;
using FlatRedBall.Graphics;
using FlatRedBall.IO;
using FlatRedBall.Input;
using FlatRedBall.Instructions;
using FlatRedBall.Math;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace FlatRedBall_Spriter
{
    public sealed class SpriterObject : PositionedObject
    {
        public PositionedObjectList<PositionedObject> ObjectList { get; private set; }
        public List<KeyFrame> KeyFrameList { get; private set; }

        public bool Animating { get; private set; }
        public float SecondsIn { get; private set; }
        public int CurrentKeyFrameIndex { get; private set; }
        public int NextKeyFrameIndex { get { return CurrentKeyFrameIndex + 1; } }

        private StringBuilder sb = new StringBuilder();

        public KeyFrame NextKeyFrame
        {
            get { return KeyFrameList.Count > NextKeyFrameIndex ? KeyFrameList[NextKeyFrameIndex] : null; }
        }

        public KeyFrame CurrentKeyFrame
        {
            get { return KeyFrameList.Count > CurrentKeyFrameIndex ? KeyFrameList[CurrentKeyFrameIndex] : null; }
        }
        public void StartAnimation()
        {
            Animating = true;
            SecondsIn = 0f;
            CurrentKeyFrameIndex = 0;
        }

        public override void TimedActivity(float secondDifference, double secondDifferenceSquaredDividedByTwo, float secondsPassedLastFrame)
        {
            base.TimedActivity(secondDifference, secondDifferenceSquaredDividedByTwo, secondsPassedLastFrame); 
            
            if (Animating)
            {
                SecondsIn += secondDifference;

                sb.AppendFormat("SecondsIn={0},", SecondsIn);

                if (NextKeyFrame != null && SecondsIn >= NextKeyFrame.Time)
                {
                    ++CurrentKeyFrameIndex;
                }

                // Interpolate between the current keyframe and next keyframe values based on time difference
                if (NextKeyFrame != null)
                {
                    float percentage = GetPercentageIntoFrame(SecondsIn, CurrentKeyFrame.Time, NextKeyFrame.Time);

                    if (percentage >= 0)
                    {


                        sb.AppendFormat("percentage={0},", percentage);

                        foreach (var currentPair in this.CurrentKeyFrame.Values)
                        {
                            var currentValues = currentPair.Value;
                            var nextValues = NextKeyFrame.Values[currentPair.Key];
                            var currentObject = currentPair.Key;

                            // Position
                            currentObject.RelativePosition = Vector3.Lerp(currentValues.Position, nextValues.Position,
                                                                          percentage);


                            // Angle
                            int spin = currentValues.Spin;
                            float angleA = currentValues.Rotation.Z;
                            float angleB = nextValues.Rotation.Z;

                            if (spin == 1 && angleB - angleA < 0)
                            {
                                angleB += 360f;
                            }
                            else if (spin == -1 && angleB - angleA >= 0)
                            {
                                angleB -= 360f;
                            }

                            currentObject.RelativeRotationZ =
                                MathHelper.ToRadians(MathHelper.Lerp(angleA,
                                                                     angleB, percentage));

                            sb.AppendFormat("RelativeRotationZ={0}", currentObject.RelativeRotationZ);
                            // Sprite specific stuff
                            var sprite = currentObject as Sprite;
                            if (sprite != null)
                            {
                                sprite.Texture = currentValues.Texture;

                                // Scale
                                sprite.ScaleX = MathHelper.Lerp(currentValues.ScaleX, nextValues.ScaleX, percentage);
                                sprite.ScaleY = MathHelper.Lerp(currentValues.ScaleY, nextValues.ScaleY, percentage);
                            }
                        } 
                    }
                }
                else
                {
                    Animating = false;
                }
                sb.AppendLine("");
            }

            if (InputManager.Keyboard.KeyDown(Keys.Space))
            {
                // does this make it only fire once?

                FileManager.SaveText(sb.ToString(), @"c:\flatredballprojects\output.csv");

            }
        }

        public static float GetPercentageIntoFrame(float secondsIntoAnimation, float currentKeyFrameTime, float nextKeyFrameTime)
        {
            return (secondsIntoAnimation - currentKeyFrameTime)/(nextKeyFrameTime - currentKeyFrameTime);
        }

        public void Destroy()
        {
            SpriteManager.RemovePositionedObject(this);
        }

        // Generated Fields
#if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
#endif

        // This is made global so that static lazy-loaded content can access it.
        public static string ContentManagerName
        {
            get;
            set;
        }

        static object mLockObject = new object();
        static List<string> mRegisteredUnloads = new List<string>();
        static List<string> LoadedContentManagers = new List<string>();

        public int Index { get; set; }
        public bool Used { get; set; }

        public Layer LayerProvidedByContainer { get; set; }

        public SpriterObject(string contentManagerName) :
            this(contentManagerName, true)
        {
        }


        public SpriterObject(string contentManagerName, bool addToManagers) :
			base()
		{
            LayerProvidedByContainer = null;
            Animating = false;
            SecondsIn = 0f;
            CurrentKeyFrameIndex = 0;
            
            ContentManagerName = contentManagerName;
            InitializeSpriterObject(addToManagers);
            KeyFrameList = new List<KeyFrame>();
            ObjectList = new PositionedObjectList<PositionedObject>();

		}

        private void InitializeSpriterObject(bool addToManagers)
		{
			// Generated Initialize
			LoadStaticContent(ContentManagerName);
			
			PostInitialize();
			if (addToManagers)
			{
				AddToManagers(null);
			}


		}

		public void AddToManagers (Layer layerToAddTo)
		{
			LayerProvidedByContainer = layerToAddTo;
			SpriteManager.AddPositionedObject(this);
           
		    foreach (var sprite in this.ObjectList.OfType<Sprite>().ToList())
		    {
		        SpriteManager.AddSprite(sprite);
                if (sprite.Parent != null && sprite.Parent.GetType() == typeof (PositionedObject))
                {
                    SpriteManager.AddPositionedObject(sprite.Parent);
                }
		    }
			AddToManagersBottomUp(layerToAddTo);
		}

		public void PostInitialize ()
		{
			bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
			FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
		}

		public void AddToManagersBottomUp (Layer layerToAddTo)
		{
			// We move this back to the origin and unrotate it so that anything attached to it can just use its absolute position
			float oldRotationX = RotationX;
			float oldRotationY = RotationY;
			float oldRotationZ = RotationZ;
			
			float oldX = X;
			float oldY = Y;
			float oldZ = Z;
			
			X = 0;
			Y = 0;
			Z = 0;
			RotationX = 0;
			RotationY = 0;
			RotationZ = 0;
			X = oldX;
			Y = oldY;
			Z = oldZ;
			RotationX = oldRotationX;
			RotationY = oldRotationY;
			RotationZ = oldRotationZ;
		}

		public void ConvertToManuallyUpdated ()
		{
			this.ForceUpdateDependenciesDeep();
			SpriteManager.ConvertToManuallyUpdated(this);
		}
		public static void LoadStaticContent (string contentManagerName)
		{
			if (string.IsNullOrEmpty(contentManagerName))
			{
				throw new ArgumentException("contentManagerName cannot be empty or null");
			}
			ContentManagerName = contentManagerName;
			#if DEBUG
			if (contentManagerName == FlatRedBallServices.GlobalContentManager)
			{
				HasBeenLoadedWithGlobalContentManager = true;
			}
			else if (HasBeenLoadedWithGlobalContentManager)
			{
				throw new Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
			}
			#endif
			bool registerUnload = false;
			if (LoadedContentManagers.Contains(contentManagerName) == false)
			{
				LoadedContentManagers.Add(contentManagerName);
				lock (mLockObject)
				{
					if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBallServices.GlobalContentManager)
					{
						FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("SpriterObjectTestEntityStaticUnload", UnloadStaticContent);
						mRegisteredUnloads.Add(ContentManagerName);
					}
				}
			}
			if (registerUnload && ContentManagerName != FlatRedBallServices.GlobalContentManager)
			{
				lock (mLockObject)
				{
					if (!mRegisteredUnloads.Contains(ContentManagerName) && ContentManagerName != FlatRedBallServices.GlobalContentManager)
					{
						FlatRedBallServices.GetContentManagerByName(ContentManagerName).AddUnloadMethod("SpriterObjectTestEntityStaticUnload", UnloadStaticContent);
						mRegisteredUnloads.Add(ContentManagerName);
					}
				}
			}
		}
		public static void UnloadStaticContent ()
		{
			if (LoadedContentManagers.Count != 0)
			{
				LoadedContentManagers.RemoveAt(0);
				mRegisteredUnloads.RemoveAt(0);
			}
			if (LoadedContentManagers.Count == 0)
			{
			}
		}

        private bool mIsPaused;
        public int AnimationTotalTime { get; set; }

        public override void Pause (InstructionList instructions)
		{
			base.Pause(instructions);
			mIsPaused = true;
		}
		public void SetToIgnorePausing ()
		{
			InstructionManager.IgnorePausingFor(this);
		}

    }
	
	
	// Extra classes
	public static class SpriterObjectTestEntityExtensionMethods
	{
	}
}
