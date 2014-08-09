using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AlertKit
{
	/*
	 * AKAlertDelegate
	 * 
	 * The main protocol that AlertKit uses to communicate alert events back to the consumer of AlertKit.
	 */
	[BaseType (typeof (NSObject))]
	[Model][Protocol]
	interface AKAlertDelegate {
		/*
		 * Invoked after a user has been successfully alerted.
		 */
		[Export ("successfullyAlertedUser"), Abstract]
		void SuccessfullyAlertedUser ();
	}

	/*
	 * Empty IAKAlertDelegate interface, so that IAKAlertDelegate can be used in ApiDefinition.
	 * Note that this interface is automatically filled in by Xamarin during build process.
	 */
	interface IAKAlertDelegate {}

	/*
	 * AKAlert
	 * 
	 * AKAlert is the main AlertKit component used by consumers of AlertKit.
	 */
	[BaseType (typeof (UIViewController))]
	interface AKAlert {
		/*
		 * Initializer to create a new `AKAlert` object.
		 * 
		 * @param alertMessage: the alert message to alert the user with.
		 * 
		 * @return A `AKAlert` object
		 */
		[Export ("initWithAlertMessage:")]
		IntPtr Constructor (NSString alertMessage);

		/*
		 * Alert the user through AlertKit.
		 */
		[Export ("alert")]
		void Alert ();

		/*
		 * Delegate for communicating alert events back to the consumer of AlertKit.
		 */
		[Export ("delegate")]
		IAKAlertDelegate Delegate { get; set; }
	}
}