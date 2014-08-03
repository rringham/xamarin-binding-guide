//
//  AlertKit.h
//  AlertKit
//
//  Created by Rob Ringham on 8/3/14.
//  Copyright (c) 2014 Rob Ringham. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface AlertKit : NSObject

- (id)initWithAlertMessage:(NSString *)alertMessage;
- (void)alert;

@property (nonatomic, readonly, assign) NSString *alertMessage;

@end