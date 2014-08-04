//
//  AKAlert.h
//  AlertKit
//
//  Created by Rob Ringham on 8/3/14.
//  Copyright (c) 2014 Rob Ringham. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@protocol AKAlertDelegate <NSObject>

- (void)successfullyAlertedUser;

@end

@interface AKAlert : NSObject<UIAlertViewDelegate>

- (id)initWithAlertMessage:(NSString *)alertMessage;
- (void)alert;

@property (nonatomic, strong) id<AKAlertDelegate> delegate;
@property (nonatomic, readonly, assign) NSString *alertMessage;

@end